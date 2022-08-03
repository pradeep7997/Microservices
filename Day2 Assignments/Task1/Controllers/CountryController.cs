Using System;
Using System.Collections.Generic;
Using System.Linq;
Using System.Net;
Using System.Net.Http;
Using System.Web.Http;
Using WebApplication1.Models;

Namespace WebApplication1.Controllers
{
        [RoutePrefix("api/Country")]
        Public Class CountryController :  ApiController
        {
            Static List<Country> Countrylist = New List<Country>()
        {
            New Country{Id=1, CountryName="Bangladesh",Capital="Dhaka"},
            New Country{Id=2, CountryName="UK",Capital="London"},
            New Country{Id=3, CountryName="India",Capital="Delhi"},
            New Country{Id=4, CountryName="USA",Capital="Newyork"},
        };

            [HttpGet]
            Public List<Country> Get()
            {
                Return Countrylist;
            }

            [HttpGet]
            [Route("{Id}")]
            Public Country GetCountryById(int id)
            {
                Country CountryObj = Countrylist.Find(item >= item.Id == id);
                Return CountryObj;
            }

            [HttpGet]
            [Route("Capital/{Capital}")]
            Public IEnumerable<Country> GetAllCountryByCapitalName(String capital)
            {
                IEnumerable<Country> capitalList = Countrylist.Where(item => item.Capital.Equals(capital));
                Return capitalList;
            }

            [HttpGet]
            [Route("CountryName/{CountryName}")]
            Public Country GetCountryByName(String CountryName)
            {
                Country obj = Countrylist.SingleOrDefault(item >= item.CountryName.Equals(CountryName));
                Return obj;
            }

            [HttpGet]
            [Route("CountryNameById/{Id}")]
            Public IHttpActionResult GetCountryName(int id)
            {
                Country CountryObj = Countrylist.Find(item >= item.Id == id);
                If (CountryObj!= null)
                {
                    Return Ok(CountryObj.CountryName);
                }
                Return NotFound();
            }


            [HttpPost]
            Public List<Country> Post([FromBody] Country obj)
            {
                Countrylist.Add(obj);
                Return Countrylist;
            }

            [HttpPut]
            [Route("{Id}")]
            Public void Put([FromBody] Country newObj)
            {
                Country oldObj = Countrylist.Find(item >= item.Id == newObj.Id);
                Countrylist.Remove(oldObj);
                Countrylist.Add(newObj);
            }

            [HttpDelete]
            [Route("{Id}")]
            Public IHttpActionResult Delete(int id)
            {
                Country obj = Countrylist.Find(item >= item.Id == id);
                If (obj!= null)
                {
                    bool isRemoved = Countrylist.Remove(obj);
                    If (isRemoved)
                    {
                        Return Ok(obj);
                    }
                }
                Return NotFound();
            }

        }
    }