using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication7;

namespace WebApplication7.Controllers
{
    public class EmployeeController : Controller
    {
        private Entities db = new Entities();

        // GET: CRONUS_Sverige_AB_Employee1
        public ActionResult Index()
        {
            return View(db.CRONUS_Sverige_AB_Employee.ToList());
        }

        // GET: CRONUS_Sverige_AB_Employee1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CRONUS_Sverige_AB_Employee cRONUS_Sverige_AB_Employee = db.CRONUS_Sverige_AB_Employee.Find(id);
            if (cRONUS_Sverige_AB_Employee == null)
            {
                return HttpNotFound();
            }
            return View(cRONUS_Sverige_AB_Employee);
        }

        // GET: CRONUS_Sverige_AB_Employee1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CRONUS_Sverige_AB_Employee1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "timestamp,Employee_No_,First_Name,Middle_Name,Last_Name,Initials,Job_Title,Search_Name,Address,Address_2,City,Post_Code,County,Phone_No_,Mobile_PhoneNo_,E_Mail,Alt__Address_Code,Alt__Address_Start_Date,Alt__Address_End_Date,Picture,Birth_Date,Social_Security_No_,Union_Code,Union_Membership_No_,Sex,Country_Region_Code,Manager_No_,Emplymt__Contract_Code,Statistics_Group_Code,Employment_Date,Status,Inactive_Date,Cause_of_Inactivity_Code,Termination_Date,Grounds_for_Term__Code,Global_Dimension_1_Code,Global_Dimension_2_Code,Resource_No_,Last_Date_Modified,Extension,Pager,Fax_No_,Company_E_Mail,Title,Salespers__Purch__Code,No__Series")] CRONUS_Sverige_AB_Employee cRONUS_Sverige_AB_Employee)
        {
            if (ModelState.IsValid)
            {
                db.CRONUS_Sverige_AB_Employee.Add(cRONUS_Sverige_AB_Employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cRONUS_Sverige_AB_Employee);
        }

        // GET: CRONUS_Sverige_AB_Employee1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CRONUS_Sverige_AB_Employee cRONUS_Sverige_AB_Employee = db.CRONUS_Sverige_AB_Employee.Find(id);
            if (cRONUS_Sverige_AB_Employee == null)
            {
                return HttpNotFound();
            }
            return View(cRONUS_Sverige_AB_Employee);
        }

        // POST: CRONUS_Sverige_AB_Employee1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "timestamp,Employee_No_,First_Name,Middle_Name,Last_Name,Initials,Job_Title,Search_Name,Address,Address_2,City,Post_Code,County,Phone_No_,Mobile_PhoneNo_,E_Mail,Alt__Address_Code,Alt__Address_Start_Date,Alt__Address_End_Date,Picture,Birth_Date,Social_Security_No_,Union_Code,Union_Membership_No_,Sex,Country_Region_Code,Manager_No_,Emplymt__Contract_Code,Statistics_Group_Code,Employment_Date,Status,Inactive_Date,Cause_of_Inactivity_Code,Termination_Date,Grounds_for_Term__Code,Global_Dimension_1_Code,Global_Dimension_2_Code,Resource_No_,Last_Date_Modified,Extension,Pager,Fax_No_,Company_E_Mail,Title,Salespers__Purch__Code,No__Series")] CRONUS_Sverige_AB_Employee cRONUS_Sverige_AB_Employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cRONUS_Sverige_AB_Employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cRONUS_Sverige_AB_Employee);
        }

        // GET: CRONUS_Sverige_AB_Employee1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CRONUS_Sverige_AB_Employee cRONUS_Sverige_AB_Employee = db.CRONUS_Sverige_AB_Employee.Find(id);
            if (cRONUS_Sverige_AB_Employee == null)
            {
                return HttpNotFound();
            }
            return View(cRONUS_Sverige_AB_Employee);
        }

        // POST: CRONUS_Sverige_AB_Employee1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CRONUS_Sverige_AB_Employee cRONUS_Sverige_AB_Employee = db.CRONUS_Sverige_AB_Employee.Find(id);
            db.CRONUS_Sverige_AB_Employee.Remove(cRONUS_Sverige_AB_Employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
