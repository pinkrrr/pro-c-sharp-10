﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace AutoLot.Samples.CompiledModels
{
    partial class ApplicationDbContextModel
    {
        partial void Initialize()
        {
            var car = CarEntityType.Create(this);
            var carDriver = CarDriverEntityType.Create(this);
            var driver = DriverEntityType.Create(this);
            var make = MakeEntityType.Create(this);
            var person = PersonEntityType.Create(this);
            var radio = RadioEntityType.Create(this);
            var carMakeViewModel = CarMakeViewModelEntityType.Create(this);

            CarEntityType.CreateForeignKey1(car, make);
            CarDriverEntityType.CreateForeignKey1(carDriver, car);
            CarDriverEntityType.CreateForeignKey2(carDriver, driver);
            PersonEntityType.CreateForeignKey1(person, driver);
            RadioEntityType.CreateForeignKey1(radio, car);

            CarEntityType.CreateSkipNavigation1(car, driver, carDriver);
            DriverEntityType.CreateSkipNavigation1(driver, car, carDriver);

            CarEntityType.CreateAnnotations(car);
            CarDriverEntityType.CreateAnnotations(carDriver);
            DriverEntityType.CreateAnnotations(driver);
            MakeEntityType.CreateAnnotations(make);
            PersonEntityType.CreateAnnotations(person);
            RadioEntityType.CreateAnnotations(radio);
            CarMakeViewModelEntityType.CreateAnnotations(carMakeViewModel);

            AddAnnotation("ProductVersion", "6.0.0-rc.1.21452.10");
            AddAnnotation("Relational:MaxIdentifierLength", 128);
            AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
        }
    }
}
