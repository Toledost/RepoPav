﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.BusinessLayer
{
    public class ViaDeConsultaService
    {
        private ViaDeConsultaDao viaDeConsultaDao;

        public ViaDeConsultaService()
        {
            viaDeConsultaDao = new ViaDeConsultaDao();
        }
        internal IList<ViaDeConsulta> GetAll()
        {
            return viaDeConsultaDao.GetAll();
        }

        internal ViaDeConsulta GetById(int idViaConsulta)
        {
            return viaDeConsultaDao.GetById(idViaConsulta);
        }

        internal void Create(ViaDeConsulta viaDeConsulta)
        {
            viaDeConsultaDao.Create(viaDeConsulta);
        }

        internal void UpDate(ViaDeConsulta viaDeConsulta)
        {
            viaDeConsultaDao.UpDate(viaDeConsulta);
        }

        internal void Delete(int idViaDeConsulta)
        {
            viaDeConsultaDao.Delete(idViaDeConsulta);
        }
    }
}
