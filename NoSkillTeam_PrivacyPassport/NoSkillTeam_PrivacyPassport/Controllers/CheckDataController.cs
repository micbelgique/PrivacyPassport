using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using NoSkillTeam_PrivacyPassport.Models;

namespace NoSkillTeam_PrivacyPassport.Controllers
{
    public class CheckDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CheckData()
        {
            return RedirectToAction("Result");
        }

        public IActionResult Result()
        {
            var ownerList = new List<Owner>();
            var personList = new List<Person>();
            var vehiculeList = new List<Vehicule>();

            var person1 = new Person()
            {
                Birthday = new DateTime(1984, 12, 15),
                FirstName = "Jonathan",
                Surname = "Cobrel",
                InscriptionNumber = 16,
                PersonID = 652655
            };

            var person2 = new Person()
            {
                Birthday = new DateTime(1967, 1, 16),
                FirstName = "Gabriel",
                Surname = "Cobrel",
                InscriptionNumber = 13,
                PersonID = 485695
            };

            var person3 = new Person()
            {
                Birthday = new DateTime(1997, 2, 16),
                FirstName = "Luna",
                Surname = "Mary",
                InscriptionNumber = 175,
                PersonID = 485695
            };

            var person4 = new Person()
            {
                Birthday = new DateTime(1990, 7, 6),
                FirstName = "Marie",
                Surname = "D'Aoste",
                InscriptionNumber = 128,
                PersonID = 485695
            };

            var person5 = new Person()
            {
                Birthday = new DateTime(1952, 4, 10),
                FirstName = "Gabriel",
                Surname = "Cobrel",
                InscriptionNumber = 178,
                PersonID = 485695
            };

            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);
            personList.Add(person4);
            personList.Add(person5);

            var vehicule1 = new Vehicule()
            {
                ConstructionYear = 1998,
                Constructor = "Mercedes",
                FuelType = "Diesel",
                MaxPower = 100,
                FirstRegistrationDate = new DateTime(1998, 16, 5),
                CubicCapacity = 1000,
                VehiculeID = 458561,
                Registration = "ABC-123"
            };

            var vehicule2 = new Vehicule()
            {
                ConstructionYear = 2012,
                Constructor = "Peugeot",
                FuelType = "Essence",
                MaxPower = 100,
                FirstRegistrationDate = new DateTime(1998, 16, 5),
                CubicCapacity = 800,
                VehiculeID = 458561,
                Registration = "1-CBA-321"
            };

            var vehicule3 = new Vehicule()
            {
                ConstructionYear = 2017,
                Constructor = "Tesla",
                FuelType = "Electrique",
                MaxPower = 100,
                FirstRegistrationDate = new DateTime(1998, 16, 5),
                CubicCapacity = 1200,
                VehiculeID = 458561,
                Registration = "1-ABC-123"
            };

            vehiculeList.Add(vehicule1);
            vehiculeList.Add(vehicule2);
            vehiculeList.Add(vehicule3);

            var owner1 = new Owner()
            {
                OwnerID = 54,
                PersonID = person1.PersonID,
                Person = person1,
                BeginDate = new DateTime(2004, 4, 16),
                Vehicule = vehicule1,
                VehiculeID = vehicule1.VehiculeID,
            };

            var owner2 = new Owner()
            {
                OwnerID = 55,
                PersonID = person2.PersonID,
                Person = person2,
                BeginDate = new DateTime(2016, 1, 12),
                Vehicule = vehicule2,
                VehiculeID = vehicule2.VehiculeID,
            };

            var owner3 = new Owner()
            {
                OwnerID = 56,
                PersonID = person3.PersonID,
                Person = person3,
                BeginDate = new DateTime(2017, 12, 1),
                Vehicule = vehicule3,
                VehiculeID = vehicule3.VehiculeID,
            };

            ownerList.Add(owner1);
            ownerList.Add(owner2);
            ownerList.Add(owner3);


            return View();
        }
    }
}