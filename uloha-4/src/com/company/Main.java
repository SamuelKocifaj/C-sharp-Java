package com.company;


public class Main {

    public static void main(String[] args) {
            GrafObject grafObject = new GrafObject(0,0);
            Kruh kruh = new Kruh(0,0,50);
            Stvorec stvorec = new Stvorec(0,0,10);

            kruh.vypocitajObsah();
            kruh.vypocitajObvod();
            stvorec.vypocitajObvod();
            stvorec.vypocitajOsah();
    }
}