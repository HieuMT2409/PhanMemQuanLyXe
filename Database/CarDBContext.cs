using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ThueXeOTo.Database
{
    public class CarDBContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HIEUMT-2491310\HIEUMT; Database=CarDB; Trusted_Connection=True; TrustServerCertificate=True");
        }

        //Cars
        public void AddCar(string name, string type, string company, string state, string price)
        {
            var car = new Car
            {
                Name = name,
                Type = type,
                Company = company,
                State = state,
                Price = price
            };

            Cars.Add(car);
            SaveChanges();
        }

        public void DeleteCar(int id)
        {
            var car = Cars.Find(id);
            if (car != null)
            {
                Cars.Remove(car);
                SaveChanges();
            }
        }

        public void UpdateCar(string id, string name, string type, string company, string price)
        {
            var car = Cars.Find(int.Parse(id));
            if (car != null)
            {
                car.Name = name;
                car.Type = type;
                car.Company = company;
                car.Price = price;

                SaveChanges();
            }
        }

        //Customers
        public void AddCustomer(string name, string sdt, string address)
        {
            var customer = new Customer
            {
                Name = name,
                SDT = sdt,
                Address = address
            };
            if(sdt.Length == 10 && sdt.All(char.IsDigit))
            {
                Customers.Add(customer);
                SaveChanges();
            }
            else
            {
                MessageBox.Show("Số điện thoại không phù hợp. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public void DeleteCustomerAndCar(int customerId)
        {
            using (var transaction = Database.BeginTransaction())
            {
                try
                {
                    var customer = Customers.Find(customerId);
                    if (customer != null)
                    {
                        Customers.Remove(customer);
                        SaveChanges();

                        //cập nhật trạng thái xe
                        var carsToUpdate = Cars.Where(c => c.Name == customer.Name && c.State == "Đang cho thuê").ToList();
                        foreach (var car in carsToUpdate)
                        {
                            car.State = "Trống";
                        }
                        SaveChanges();

                        //nếu tất cả câu lệnh đều hoàn tất thì commit
                        transaction.Commit();
                        MessageBox.Show("Xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void UpdateCustomer(string id, string name, string sdt, string address)
        {
            var customer = Customers.Find(int.Parse(id));
            if (customer != null)
            {
                customer.Name = name;
                customer.SDT = sdt;
                customer.Address = address;

                SaveChanges();
            }
        }
        //Orders

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>().Property(e => e.ID).IsRequired();
            modelBuilder.Entity<User>().Property(e => e.Id).IsRequired();
            modelBuilder.Entity<Order>().Property(e => e.OrderID).IsRequired();
            modelBuilder.Entity<Customer>().Property(e => e.ID).IsRequired();
        }
    }
}
