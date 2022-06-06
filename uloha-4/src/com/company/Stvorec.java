package com.company;

public class Stvorec extends GrafObject{
    private float a;


    public Stvorec(float posX, float posY, float a){
        super(posX, posY);
        this.a=a;


    }
    public void vypocitajObvod(){
        this.Obvod= a*4;
        System.out.println(this.Obvod);
    }
    public void vypocitajOsah(){
        this.Obvod= a*a;
        System.out.println(this.Obsah);
    }
}
