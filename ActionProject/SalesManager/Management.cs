using ActionProject;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SalesManager
{
    class Management
    {
        public List<Iproduct> _products = new List<Iproduct> { };
        public List<InterfaceAgent> _agents = new List<InterfaceAgent> { };
        List<InterfaceAgent> _whowantbuy = new List<InterfaceAgent> { };


        public void Participante()
        {
            
            foreach (var agent in _agents)
            {
                var obj = agent;
                Task.Factory.StartNew(itsobject =>
                {
                    bool answer = ((InterfaceAgent)itsobject).Participantion();
                    if (answer)
                        _whowantbuy.Add(obj);

                }, obj);
            }

        }


        public void StartAction() // show the startcost
        {
            Random _random4 = new Random();
            int num4 = _random4.Next(50);
            foreach (var agent in _whowantbuy)
            {
                var obj = agent;
                Task.Factory.StartNew(itsobject =>
                {
                    ((InterfaceAgent)itsobject).getstartcost(num4);

                }, obj);

            }
        }

        public void Descriptionofproduct(Iproduct oneproduct)
        {
            foreach (var agent in _whowantbuy)
            {
                var obj = agent;
                Task.Factory.StartNew(itsobject =>
                {
                    ((InterfaceAgent)itsobject).abouttheproduct(oneproduct.name());

                }, obj);

            }
        }

        public void Nameofproduct(Iproduct onename) //show the name of the product
        {
                foreach (var agent in _whowantbuy)
                {
                    var obj = agent;
                    Task.Factory.StartNew(itsobject2 =>
                    {
                        ((InterfaceAgent)itsobject2).nameofproduct(onename.name());

                    }, obj);
                }
        }

        public void sellgap()
        {
            Random _random3 = new Random();
            int num3 = _random3.Next(30);
            foreach (var agent in _whowantbuy)
            {
                var obj = agent;
                Task.Factory.StartNew(itsobject2 =>
                {
                    ((InterfaceAgent)itsobject2).getsellgap(num3);

                }, obj);
            };
        }

        public void Newpricefromagent(int cost)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            foreach (var agent in _whowantbuy)
            {
                var obj = agent;
                Task.Factory.StartNew(itsobject =>
                {
                    bool answer = ((InterfaceAgent)itsobject).Participantion();
                    if (answer)



                }, obj);

            }
        }
        






    }
}
