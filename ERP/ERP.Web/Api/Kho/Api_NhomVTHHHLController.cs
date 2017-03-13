﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ERP.Web.Models.Database;

namespace ERP.Web.Areas.HopLong.Api.Kho
{
    public class Api_NhomVTHHHLController : ApiController
    {
        private HOPLONG_DATABASEEntities db = new HOPLONG_DATABASEEntities();

        // GET: api/Api_NhomVTHHHL
        public List<DM_NHOM_VTHH> GetDM_NHOM_VTHH()
        {
            var vData = db.DM_NHOM_VTHH;
            var result = vData.ToList().Select(x => new DM_NHOM_VTHH()
            {
                MA_NHOM_HANG_CHI_TIET = x.MA_NHOM_HANG_CHI_TIET,
                CHUNG_LOAI_HANG = x.CHUNG_LOAI_HANG,
                MA_NHOM_HANG_CHA = x.MA_NHOM_HANG_CHA,
                GHI_CHU = x.GHI_CHU
            }).ToList();
            return result;
        }

        // GET: api/Api_NhomVTHHHL/5
        [ResponseType(typeof(DM_NHOM_VTHH))]
        public IHttpActionResult GetDM_HANG_SP(string id)
        {
            DM_NHOM_VTHH dM_HANG_SP = db.DM_NHOM_VTHH.Find(id);
            if (dM_HANG_SP == null)
            {
                return NotFound();
            }

            return Ok(dM_HANG_SP);
        }

        // PUT: api/Api_NhomVTHHHL/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDM_HANG_SP(string id, DM_NHOM_VTHH dM_NHOM_VTHH)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dM_NHOM_VTHH.MA_NHOM_HANG_CHI_TIET)
            {
                return BadRequest();
            }

            db.Entry(dM_NHOM_VTHH).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DM_HANG_SPExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Api_NhomVTHHHL
        [ResponseType(typeof(DM_NHOM_VTHH))]
        public IHttpActionResult PostDM_HANG_SP(DM_NHOM_VTHH dM_NHOM_VTHH)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DM_NHOM_VTHH.Add(dM_NHOM_VTHH);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (DM_HANG_SPExists(dM_NHOM_VTHH.MA_NHOM_HANG_CHI_TIET))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = dM_NHOM_VTHH.MA_NHOM_HANG_CHI_TIET }, dM_NHOM_VTHH);
        }

        // DELETE: api/Api_NhomVTHHHL/5
        [ResponseType(typeof(DM_NHOM_VTHH))]
        public IHttpActionResult DeleteDM_HANG_SP(string id)
        {
            DM_NHOM_VTHH dM_HANG_SP = db.DM_NHOM_VTHH.Find(id);
            if (dM_HANG_SP == null)
            {
                return NotFound();
            }

            db.DM_NHOM_VTHH.Remove(dM_HANG_SP);
            db.SaveChanges();

            return Ok(dM_HANG_SP);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DM_HANG_SPExists(string id)
        {
            return db.DM_NHOM_VTHH.Count(e => e.MA_NHOM_HANG_CHI_TIET == id) > 0;
        }
    }
}