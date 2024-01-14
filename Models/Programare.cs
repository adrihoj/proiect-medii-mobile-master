﻿using SQLite;
using SQLiteNetExtensions.Attributes;
using System;

namespace ProiectMobile.Models
{
    public class Programare
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string NumeBeneficiar { get; set; }
        public DateTime DataProgramare { get; set; }
        [ForeignKey(typeof(Serviciu))]
        public int ServiciuId { get; set; }
        [OneToOne]
        public Serviciu serviciu { get; set; }
    }
}
