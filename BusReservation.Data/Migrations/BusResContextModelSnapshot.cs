// <auto-generated />
using System;
using BusReservation.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusReservation.Data.Migrations
{
    [DbContext(typeof(BusResContext))]
    partial class BusResContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("BusReservation.Entity.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CityName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RouteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CityId");

                    b.HasIndex("RouteId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("BusReservation.Entity.Route", b =>
                {
                    b.Property<int>("RouteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RouteClock")
                        .HasColumnType("TEXT");

                    b.Property<string>("RouteDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("RouteFinish")
                        .HasColumnType("TEXT");

                    b.Property<string>("RouteFirstTransfer")
                        .HasColumnType("TEXT");

                    b.Property<string>("RouteFourthTransfer")
                        .HasColumnType("TEXT");

                    b.Property<double>("RoutePrice")
                        .HasColumnType("REAL");

                    b.Property<string>("RouteSecondTransfer")
                        .HasColumnType("TEXT");

                    b.Property<string>("RouteStart")
                        .HasColumnType("TEXT");

                    b.Property<string>("RouteThirdTransfer")
                        .HasColumnType("TEXT");

                    b.HasKey("RouteId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("BusReservation.Entity.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("RouteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TicketClock")
                        .HasColumnType("TEXT");

                    b.Property<string>("TicketDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("TicketFromWhere")
                        .HasColumnType("TEXT");

                    b.Property<string>("TicketGender")
                        .HasColumnType("TEXT");

                    b.Property<string>("TicketMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("TicketName")
                        .HasColumnType("TEXT");

                    b.Property<int>("TicketPnrNo")
                        .HasColumnType("INTEGER");

                    b.Property<double>("TicketPrice")
                        .HasColumnType("REAL");

                    b.Property<int>("TicketSeatNo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TicketSurname")
                        .HasColumnType("TEXT");

                    b.Property<string>("TicketToWhere")
                        .HasColumnType("TEXT");

                    b.HasKey("TicketId");

                    b.HasIndex("RouteId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("BusReservation.Entity.City", b =>
                {
                    b.HasOne("BusReservation.Entity.Route", null)
                        .WithMany("City")
                        .HasForeignKey("RouteId");
                });

            modelBuilder.Entity("BusReservation.Entity.Ticket", b =>
                {
                    b.HasOne("BusReservation.Entity.Route", "Route")
                        .WithMany()
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Route");
                });

            modelBuilder.Entity("BusReservation.Entity.Route", b =>
                {
                    b.Navigation("City");
                });
#pragma warning restore 612, 618
        }
    }
}
