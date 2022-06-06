package com.company;
import java.sql.Array;


public class GrafObject {
    protected double Obsah;
    protected double Obvod;
    protected float posX;
    protected float posY;

    public GrafObject(float posX, float posY){
            this.posX = posX;
            this.posY = posY;
    }
    public double getObvod(){return this.Obvod;}

    public double getObsah(){return this.Obsah;}
}
