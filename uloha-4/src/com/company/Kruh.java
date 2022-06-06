package com.company;

public class Kruh extends GrafObject {
    private float radius;

    public Kruh(float posX, float posY, float radius){
        super(posX, posY);
        this.radius= radius;
    }
    public void vypocitajObvod(){
        this.Obvod= 2*3.14*this.radius;
        System.out.println(this.Obvod);
    }
    public void vypocitajObsah(){
        this.Obsah= 3.14*this.radius*this.radius;
        System.out.println(this.Obsah);
    }
}
