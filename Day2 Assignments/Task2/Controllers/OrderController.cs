Using System;
Using System.Collections.Generic;
Using System.Data;
Using System.Data.Entity;
Using System.Linq;
Using System.Net;
Using System.Web;
Using System.Web.Mvc;
Using WebApplication1.Models;

Namespace WebApplication1.Controllers
{
    Public Class OrderController :  Controller
    {
        Private Assignment_DBEntities db = New Assignment_DBEntities();

        Public ActionResult Index()
        {
            Return View(db.Orders.ToList());
        }

        Public ActionResult Details(int? id)
        {
            If (id == null)
            {
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order Order = db.Orders.Find(id);
            If (Order == null)
            {
                Return HttpNotFound();
            }
            Return View(Order);
        }


        Public ActionResult Create()
        {
            Return View();
        }


        [HttpPost]
        Public ActionResult Create([Bind(Include = "OrderId,Customer_name,Order_amount, Order_date")] Order Order)
        {
            If (ModelState.IsValid)
            {
                db.Orders.Add(Order);
                db.SaveChanges();
                Return RedirectToAction("Index");
            }

            Return View(Order);
        }


        Public ActionResult Edit(int? id)
        {
            If (id == null)
            {
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order Order = db.Orders.Find(id);
            If (Order == null)
            {
                Return HttpNotFound();
            }
            Return View(Order);
        }


        [HttpPost]
        Public ActionResult Edit([Bind(Include = "OrderId,Customer_name,Order_amount, Order_date")] Order Order)
        {
            If (ModelState.IsValid)
            {
                db.Entry(Order).State = EntityState.Modified;
                db.SaveChanges();
                Return RedirectToAction("Index");
            }
            Return View(Order);
        }


        Public ActionResult Delete(int? id)
        {
            If (id == null)
            {
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order Order = db.Orders.Find(id);
            If (Order == null)
            {
                Return HttpNotFound();
            }
            Return View(Order);
        }


        [HttpPost, ActionName("Delete")]
        Public ActionResult DeleteConfirmed(int id)
        {
            Order sample = db.Orders.Find(id);
            db.Orders.Remove(sample);
            db.SaveChanges();
            Return RedirectToAction("Index");
        }
    }
}