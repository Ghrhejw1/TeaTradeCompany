using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TeaTradeCompany.Model;

namespace TeaTradeCompany
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Покупатель> Покупатель { get; set; }
        public DbSet<Магазины> Магазин { get; set; }
        public DbSet<Поставщик> Поставщик { get; set; }
        public DbSet<Сортировочный_центр> Сортировочный_центр { get; set; }
        public DbSet<Склад> Склад { get; set; }
        public DbSet<Отгрузка> Отгрузка { get; set; }
        public DbSet<Плантация> Плантация { get; set; }
        public DbSet<Участок> Участок { get; set; }
        public DbSet<Департамент> Департамент { get; set; }
        public DbSet<Сотрудники> Сотрудники { get; set; }
        public DbSet<Чайный_куст> Чайный_Куст { get; set; }
        public DbSet<Параметры_климата> Параметры_Климата { get; set; }
        public DbSet<Обработка_чая> Обработка_Чая { get; set; }
        public DbSet<Заказ> Заказ { get; set; }
        public DbSet<Продукт> Продукт { get; set; }
        public DbSet<Технологический_Процесс> Технологический_Процесс { get; set; }
        public DbSet<Используемое_оборудование> Используемое_оборудование { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=localhost;Initial Catalog=Tea_Plantation;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Покупатель>()
              .HasOne(p => p.Магазин)
              .WithMany(m => m.Покупатели)
              .HasForeignKey(p => p.FK_Магазина);

            modelBuilder.Entity<Сортировочный_центр>()
                .HasOne(s => s.Поставщик)
                .WithMany(p => p.СортировочныеЦентры)
                .HasForeignKey(s => s.FK_Поставщика);

            modelBuilder.Entity<Отгрузка>()
                .HasOne(o => o.Заказ)
                .WithMany(z => z.Отгрузки)
                .HasForeignKey(o => o.FK_Заказа);

            modelBuilder.Entity<Отгрузка>()
                .HasOne(o => o.Склад)
                .WithMany(s => s.Отгрузки)
                .HasForeignKey(o => o.FK_Склада);

            modelBuilder.Entity<Участок>()
                .HasOne(u => u.Плантация)
                .WithMany(p => p.Участки)
                .HasForeignKey(u => u.FK_Плантации);

            modelBuilder.Entity<Участок>()
                .HasOne(u => u.ЧайныйКуст)
                .WithMany(c => c.Участки)
                .HasForeignKey(u => u.FK_Чайного_куста);

            modelBuilder.Entity<Департамент>()
                .HasOne(d => d.Сотрудник)
                .WithMany(s => s.Департаменты)
                .HasForeignKey(d => d.FK_Сотрудника);

            modelBuilder.Entity<Департамент>()
                .HasOne(d => d.Плантация)
                .WithMany(p => p.Департаменты)
                .HasForeignKey(d => d.FK_Плантации);

            modelBuilder.Entity<Параметры_климата>()
                .HasOne(p => p.ЧайныйКуст)
                .WithMany(c => c.ПараметрыКлимата)
                .HasForeignKey(p => p.FK_Чайного_куста_климат);

            modelBuilder.Entity<Обработка_чая>()
                .HasOne(o => o.Продукт)
                .WithMany(p => p.Обработки)
                .HasForeignKey(o => o.FK_Продукта);

            modelBuilder.Entity<Обработка_чая>()
                .HasOne(o => o.Процесс)
                .WithMany(t => t.ОбработкиЧая)
                .HasForeignKey(o => o.FK_Процесса);

            modelBuilder.Entity<Технологический_Процесс>()
                .HasOne(t => t.Оборудование)
                .WithMany(e => e.ТехнологическиеПроцессы)
                .HasForeignKey(t => t.FK_Процесса_Оборудования);

            modelBuilder.Entity<Заказ>()
                .HasOne(z => z.Продукт)
                .WithMany(p => p.Заказы)
                .HasForeignKey(z => z.FK_Продукта);

            // Additional entity configurations
            modelBuilder.Entity<Магазины>()
                .HasMany(m => m.Покупатели)
                .WithOne(p => p.Магазин)
                .HasForeignKey(p => p.FK_Магазина);

            modelBuilder.Entity<Поставщик>()
                .HasMany(p => p.СортировочныеЦентры)
                .WithOne(s => s.Поставщик)
                .HasForeignKey(s => s.FK_Поставщика);

            modelBuilder.Entity<Склад>()
                .HasMany(s => s.Отгрузки)
                .WithOne(o => o.Склад)
                .HasForeignKey(o => o.FK_Склада);

            modelBuilder.Entity<Плантация>()
                .HasMany(p => p.Участки)
                .WithOne(u => u.Плантация)
                .HasForeignKey(u => u.FK_Плантации);

            modelBuilder.Entity<Плантация>()
                .HasMany(p => p.Департаменты)
                .WithOne(d => d.Плантация)
                .HasForeignKey(d => d.FK_Плантации);

            modelBuilder.Entity<Чайный_куст>()
                .HasMany(c => c.ПараметрыКлимата)
                .WithOne(p => p.ЧайныйКуст)
                .HasForeignKey(p => p.FK_Чайного_куста_климат);

            modelBuilder.Entity<Чайный_куст>()
                .HasMany(c => c.Участки)
                .WithOne(u => u.ЧайныйКуст)
                .HasForeignKey(u => u.FK_Чайного_куста);

            modelBuilder.Entity<Продукт>()
                .HasMany(p => p.Обработки)
                .WithOne(o => o.Продукт)
                .HasForeignKey(o => o.FK_Продукта);

            modelBuilder.Entity<Продукт>()
                .HasMany(p => p.Заказы)
                .WithOne(z => z.Продукт)
                .HasForeignKey(z => z.FK_Продукта);

            modelBuilder.Entity<Используемое_оборудование>()
                .HasMany(e => e.ТехнологическиеПроцессы)
                .WithOne(t => t.Оборудование)
                .HasForeignKey(t => t.FK_Процесса_Оборудования);
        }
    }
}