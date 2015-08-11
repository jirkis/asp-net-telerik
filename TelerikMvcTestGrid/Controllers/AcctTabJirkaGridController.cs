﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TelerikMvcTestGrid.Models;

namespace TelerikMvcTestGrid.Controllers
{
    public class AcctTabJirkaGridController : Controller
    {
        private TpiiEntities db = new TpiiEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ACCT_TAB_JIRKA_Read([DataSourceRequest]DataSourceRequest request)
        {
            IQueryable<ACCT_TAB_JIRKA> acct_tab_jirka = db.ACCT_TAB_JIRKA;
            DataSourceResult result = acct_tab_jirka.ToDataSourceResult(request, aCCT_TAB_JIRKA => new {
                AACCT = aCCT_TAB_JIRKA.AACCT,
                ABAL = aCCT_TAB_JIRKA.ABAL,
                AREST = aCCT_TAB_JIRKA.AREST,
                AWDL_START = aCCT_TAB_JIRKA.AWDL_START,
                AWDL_LEN = aCCT_TAB_JIRKA.AWDL_LEN,
                AWDL_LMT = aCCT_TAB_JIRKA.AWDL_LMT,
                AWDL_TDY = aCCT_TAB_JIRKA.AWDL_TDY,
                TRN_DT = aCCT_TAB_JIRKA.TRN_DT,
                POS_START = aCCT_TAB_JIRKA.POS_START,
                POS_LEN = aCCT_TAB_JIRKA.POS_LEN,
                POS_LMT = aCCT_TAB_JIRKA.POS_LMT,
                POS_TDY = aCCT_TAB_JIRKA.POS_TDY,
                CURRENCY_TYPE = aCCT_TAB_JIRKA.CURRENCY_TYPE,
                HOLD_AMOUNT = aCCT_TAB_JIRKA.HOLD_AMOUNT,
                ACTUAL_BAL = aCCT_TAB_JIRKA.ACTUAL_BAL,
                LAST_UPDATE = aCCT_TAB_JIRKA.LAST_UPDATE,
                ACCT_SEGMENT = aCCT_TAB_JIRKA.ACCT_SEGMENT
            });

            return Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ACCT_TAB_JIRKA_Create([DataSourceRequest]DataSourceRequest request, ACCT_TAB_JIRKA aCCT_TAB_JIRKA)
        {
            if (ModelState.IsValid)
            {
                var entity = new ACCT_TAB_JIRKA
                {
                    ABAL = aCCT_TAB_JIRKA.ABAL,
                    AREST = aCCT_TAB_JIRKA.AREST,
                    AWDL_START = aCCT_TAB_JIRKA.AWDL_START,
                    AWDL_LEN = aCCT_TAB_JIRKA.AWDL_LEN,
                    AWDL_LMT = aCCT_TAB_JIRKA.AWDL_LMT,
                    AWDL_TDY = aCCT_TAB_JIRKA.AWDL_TDY,
                    TRN_DT = aCCT_TAB_JIRKA.TRN_DT,
                    POS_START = aCCT_TAB_JIRKA.POS_START,
                    POS_LEN = aCCT_TAB_JIRKA.POS_LEN,
                    POS_LMT = aCCT_TAB_JIRKA.POS_LMT,
                    POS_TDY = aCCT_TAB_JIRKA.POS_TDY,
                    CURRENCY_TYPE = aCCT_TAB_JIRKA.CURRENCY_TYPE,
                    HOLD_AMOUNT = aCCT_TAB_JIRKA.HOLD_AMOUNT,
                    ACTUAL_BAL = aCCT_TAB_JIRKA.ACTUAL_BAL,
                    LAST_UPDATE = aCCT_TAB_JIRKA.LAST_UPDATE,
                    ACCT_SEGMENT = aCCT_TAB_JIRKA.ACCT_SEGMENT
                };

                db.ACCT_TAB_JIRKA.Add(entity);
                db.SaveChanges();
                aCCT_TAB_JIRKA.AACCT = entity.AACCT;
            }

            return Json(new[] { aCCT_TAB_JIRKA }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ACCT_TAB_JIRKA_Update([DataSourceRequest]DataSourceRequest request, ACCT_TAB_JIRKA aCCT_TAB_JIRKA)
        {
            if (ModelState.IsValid)
            {
                var entity = new ACCT_TAB_JIRKA
                {
                    AACCT = aCCT_TAB_JIRKA.AACCT,
                    ABAL = aCCT_TAB_JIRKA.ABAL,
                    AREST = aCCT_TAB_JIRKA.AREST,
                    AWDL_START = aCCT_TAB_JIRKA.AWDL_START,
                    AWDL_LEN = aCCT_TAB_JIRKA.AWDL_LEN,
                    AWDL_LMT = aCCT_TAB_JIRKA.AWDL_LMT,
                    AWDL_TDY = aCCT_TAB_JIRKA.AWDL_TDY,
                    TRN_DT = aCCT_TAB_JIRKA.TRN_DT,
                    POS_START = aCCT_TAB_JIRKA.POS_START,
                    POS_LEN = aCCT_TAB_JIRKA.POS_LEN,
                    POS_LMT = aCCT_TAB_JIRKA.POS_LMT,
                    POS_TDY = aCCT_TAB_JIRKA.POS_TDY,
                    CURRENCY_TYPE = aCCT_TAB_JIRKA.CURRENCY_TYPE,
                    HOLD_AMOUNT = aCCT_TAB_JIRKA.HOLD_AMOUNT,
                    ACTUAL_BAL = aCCT_TAB_JIRKA.ACTUAL_BAL,
                    LAST_UPDATE = aCCT_TAB_JIRKA.LAST_UPDATE,
                    ACCT_SEGMENT = aCCT_TAB_JIRKA.ACCT_SEGMENT
                };

                db.ACCT_TAB_JIRKA.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }

            return Json(new[] { aCCT_TAB_JIRKA }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ACCT_TAB_JIRKA_Destroy([DataSourceRequest]DataSourceRequest request, ACCT_TAB_JIRKA aCCT_TAB_JIRKA)
        {
            if (ModelState.IsValid)
            {
                var entity = new ACCT_TAB_JIRKA
                {
                    AACCT = aCCT_TAB_JIRKA.AACCT,
                    ABAL = aCCT_TAB_JIRKA.ABAL,
                    AREST = aCCT_TAB_JIRKA.AREST,
                    AWDL_START = aCCT_TAB_JIRKA.AWDL_START,
                    AWDL_LEN = aCCT_TAB_JIRKA.AWDL_LEN,
                    AWDL_LMT = aCCT_TAB_JIRKA.AWDL_LMT,
                    AWDL_TDY = aCCT_TAB_JIRKA.AWDL_TDY,
                    TRN_DT = aCCT_TAB_JIRKA.TRN_DT,
                    POS_START = aCCT_TAB_JIRKA.POS_START,
                    POS_LEN = aCCT_TAB_JIRKA.POS_LEN,
                    POS_LMT = aCCT_TAB_JIRKA.POS_LMT,
                    POS_TDY = aCCT_TAB_JIRKA.POS_TDY,
                    CURRENCY_TYPE = aCCT_TAB_JIRKA.CURRENCY_TYPE,
                    HOLD_AMOUNT = aCCT_TAB_JIRKA.HOLD_AMOUNT,
                    ACTUAL_BAL = aCCT_TAB_JIRKA.ACTUAL_BAL,
                    LAST_UPDATE = aCCT_TAB_JIRKA.LAST_UPDATE,
                    ACCT_SEGMENT = aCCT_TAB_JIRKA.ACCT_SEGMENT
                };

                db.ACCT_TAB_JIRKA.Attach(entity);
                db.ACCT_TAB_JIRKA.Remove(entity);
                db.SaveChanges();
            }

            return Json(new[] { aCCT_TAB_JIRKA }.ToDataSourceResult(request, ModelState));
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
