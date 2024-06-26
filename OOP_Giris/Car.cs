﻿using System.Runtime.CompilerServices;

namespace OOP_Giris;

public class Car
{

    public Car()
    {

    }

    public Car(double motorHacim, string renk, double fiyat, string yakit, string marka, int modelYili)
    {
        this.motorHacim = motorHacim;
        this.renk = renk;
        this.fiyat = fiyat;
        this.yakitTuru = yakit;
        this.markaAdi = marka;
        this.modelYili = modelYili;
    }

    public double motorHacim;

    public string renk;

    public double fiyat;

    public string yakitTuru;

    public string markaAdi;

    public int modelYili;


    public override string ToString()
    {
        return $"Aracın markası: {markaAdi} , Model: {modelYili} , rengi: {renk}, fiyat: {fiyat}";
    }

}
