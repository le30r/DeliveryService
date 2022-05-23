using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSADB.Model;
using Dadata;
using MaterialSkin.Controls;

namespace CSADB
{
    internal class Controller
    {
        public readonly DeliveryServiceEDM context;
        static Controller instance = null;
        public List<Client> clients;
        public List<City> cities;
        public List<CargoType> types;
        public static string token = "582d94bf3d0a3b913e44335807fc2c653b2087d3";
       

        public int lastCargoIndex;
        public int lastDeliveryIndex;
        internal string ConnectionString = "data source=DESKTOP-8ER83ML\\SQLEXPRESS;initial catalog=DeliveryService;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

        public static Controller GetInstance()
        {
            if (instance == null)
            {
                instance = new Controller();
            }
            return instance;
        }
        private Controller()
        {
            context = new DeliveryServiceEDM();
            GetClients();
            GetCities();
            GetCargoTypes();
            lastCargoIndex = context.Cargo.OrderByDescending(c => c.CargoID).FirstOrDefault() != null ? 
                                        context.Cargo.OrderByDescending(c => c.CargoID).FirstOrDefault().CargoID + 1 : 0;
            lastDeliveryIndex = context.Delivery.OrderByDescending(d => d.DeliveryID).FirstOrDefault() != null ?  
                context.Delivery.OrderByDescending(d => d.DeliveryID).FirstOrDefault().DeliveryID + 1 : 0;
        }

        internal List<Delivery> GetFreeDeliveriesyByCity(int city)
        {
            return context.Delivery.Where(c => (c.DeliveryCity == city) && (c.DeliveryStatus < 4)).ToList();
        }

        internal void AddCourierDelivery(Courier courier, Delivery delivery)
        {
            var courierDelivery = new CourierDelivery();
            courierDelivery.Courier1 = courier;
            courierDelivery.Delivery1 = delivery;
            context.CourierDelivery.Add(courierDelivery);
            Commit();
        }
        internal Courier GetCourierById(int id)
        {
            return context.Courier.Where(c=>c.CourierID == id).FirstOrDefault();
        }

        private void GetCargoTypes()
        {
            types = context.CargoType.ToList();
        }

       

        internal List<String> GetPartnerCompanies()
        {
           return context.PartnerCompany.Select(x=>x.CompanyName).ToList();
        }

        internal void DestroyContext()
        {
            context.Dispose();
        }

        internal Users Auth(string login, string password)
        {           

            Users user = context.Users.Where(l => l.UserLogin == login).FirstOrDefault();
            if (user != null)
            {
                if (Verify(login, password, user.PasswordHash))
                {
                    return user;
                }
                else
                {
                    MaterialMessageBox.Show("Введен неверный пароль");
                }
            } 
            else
            {
                MaterialMessageBox.Show("Данного пользователя не существует");
            }
            return null;
        }

        internal List<Storage> GetStorages()
        {
            return context.Storage.ToList();
        }

        internal List<string> GetTariffs()
        {
            return context.Tariff.Select(x=>x.TariffName).ToList();
        }

        internal void GetCities()
        {
            cities = context.City.ToList();
        }
        

        internal string GetPostamatAddress(int id)
        {
            return context.Postamat.Where(x => x.PostamatID == id).FirstOrDefault().PostamatAddress;
        }

        internal int GetCourier(Delivery delivery)
        {
            return context.CourierDelivery.Where(x=>x.Delivery == delivery.DeliveryID).FirstOrDefault().Courier;
        }

        internal List<string> GetPostamats()
        {
           return context.Postamat.OrderBy(x=> x.PostamatID).Select(x=>x.PostamatAddress).ToList();
        }

        internal string GetCargoTypeById(int cargoType)
        {
            return context.CargoType.Where(c=>c.TypeID == cargoType).FirstOrDefault().TypeName;
        }

        internal Tariff GetTariff(int value)
        {
            return context.Tariff.Where(x=>x.TariffID == value).FirstOrDefault();
        }

        internal Tariff GetTariffByName(string name)
        {
            return context.Tariff.Where(x=>x.TariffName == name).FirstOrDefault();
        }

        internal DeliveryStatus GetStatus(int i)
        {
            return context.DeliveryStatus.Where(x => x.StatusID == i).FirstOrDefault();
        }

        internal Delivery GetDeliveryById(long id)
        {
            return context.Delivery.Where(x => x.DeliveryID == id).FirstOrDefault();
        }

        internal List<Delivery> GetDeliveryList(Client client)
        {
            return context.Delivery.Where(x=>x.Client.ClientID == client.ClientID).ToList();
        }

        internal List<Cargo> GetCargos(Delivery delivery)
        {
            var id = delivery.DeliveryID;
            return context.Cargo.Where(x=>x.Delivery.FirstOrDefault().DeliveryID==id).ToList();
        }
        internal List<Cargo> GetCargos(int clientId)
        {
            return context.Cargo.Where(x => x.Shipper == clientId).ToList();
        }

        internal Cargo GetCargoById(int id)
        {
            return context.Cargo.Where(x=>x.CargoID == id).FirstOrDefault();
        }
        internal void GetClients()
        {
           clients = context.Client.ToList();
        }

        internal Delivery GetActiveDelivery(Courier courier)
        {

            var courDel = context.CourierDelivery.Where(x => x.Courier == courier.CourierID).Where(x => x.Delivery1.DeliveryStatus != 5).FirstOrDefault();
            return courDel != null ? courDel.Delivery1 : null;
        }

        internal void Register(string lastName, string name, string middleName, 
            string phone, string email, string login, string password, bool isCourier, int city, DateTime birthday, bool car)
        {
            Users user = new Users();
            Courier courier = new Courier();
            Client client = new Client();
            user.UserLogin = login;
            user.PasswordHash = GetHash(login, password);
            user.ID = context.Users.OrderByDescending(x => x.ID).FirstOrDefault().ID + 1;
            long phNum = Convert.ToInt64(Regex.Replace(phone, @"[^\d]+", ""));
            


            if (isCourier)
            {
                user.AccessLevel = 1;
                context.Users.Add(user);
                courier.LastName = lastName;
                courier.FirstName = name;
                courier.MiddleName = middleName;
                courier.Phone = phNum;
                courier.CourierID = user.ID;
                courier.Birthday = birthday;
                courier.Car = car;
                courier.City = city;
                courier.District = "не указан";
                context.Courier.Add(courier);

            } 
            else
            {
                user.AccessLevel = 0;
                context.Users.Add(user);
                client.LastName = lastName;
                client.FirstName = name;
                client.MiddleName = middleName;
                client.Phone = phNum;
                client.Email = email;
                client.ClientID = user.ID;
                context.Client.Add(client);  
            }

            context.SaveChanges();
        }

        internal void Commit()
        {
            context.SaveChanges();
        }

        public Client GetClientByID(int ID)
        {
            return context.Client.Where(c => c.ClientID == ID).FirstOrDefault();
        }

        public bool isLoginExists(string login)
        {
            return context.Users.Where(x=>x.UserLogin == login).Count() > 0;
        }
        string GetHash(string login, string password)
        {
            string loginString = "C1A3S3D7B" + login + password;
            var hash = HashPassword(loginString);
            Console.WriteLine(hash);
            return hash;
        }

        bool Verify(string login, string password, string hashedPass)
        {
            Console.WriteLine(GetHash(login, password));
            return VerifyHashedPassword(hashedPass, "C1A3S3D7B" + login + password);
        }

        public static string HashPassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }

        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            byte[] buffer4;
            if (hashedPassword == null)
            {
                return false;
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            byte[] src = Convert.FromBase64String(hashedPassword);
            if ((src.Length != 0x31) || (src[0] != 0))
            {
                return false;
            }
            byte[] dst = new byte[0x10];
            Buffer.BlockCopy(src, 1, dst, 0, 0x10);
            byte[] buffer3 = new byte[0x20];
            Buffer.BlockCopy(src, 0x11, buffer3, 0, 0x20);
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, dst, 0x3e8))
            {
                buffer4 = bytes.GetBytes(0x20);
            }
            return ByteArraysEqual(buffer3, buffer4);
        }

        public static bool ByteArraysEqual(byte[] b1, byte[] b2)
        {
            if (b1 == b2) return true;
            if (b1 == null || b2 == null) return false;
            if (b1.Length != b2.Length) return false;
            for (int i = 0; i < b1.Length; i++)
            {
                if (b1[i] != b2[i]) return false;
            }
            return true;
        }
    }
}
