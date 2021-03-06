﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Week1.Fundamentals;
using Fundamentals;

namespace Advanced
{
    public class CollectionExamples
    {
        public void MyArrayListExample()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hello");
            arrayList.Add("World");

            Console.WriteLine("Count = " + arrayList.Count);

            arrayList.RemoveAt(2);
            arrayList.Reverse();


            foreach (Object obj in arrayList)
            {
                Console.WriteLine("type = " + obj);
            }
        }

        public List<dinosaur> MyListExample()
        {
            List<dinosaur> myDinos = new List<dinosaur>();
            myDinos.Add(new dinosaur() { Size = 50, Teeth = "Serrated", Skin = true });
            myDinos.Add(new Pterodactyl() { Size = 25, Teeth = "Sharp" });
            myDinos.Add(new dinosaur.Raptor() { Size = 10, Teeth = "Serrated", Skin = false });

            return myDinos;
            /*
            foreach (dinosaur dinosaur in myDinos)
            {
                Console.WriteLine(dinosaur);
            }*/
        }


    }
}
