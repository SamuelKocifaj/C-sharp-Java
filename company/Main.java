package com.company;

public class Main {
    public static void main(String[] args) {
        kocka Kocka = new kocka(10);
        Bojovnik bojovnik = new Bojovnik("Adolf",100,20,10,Kocka);

        System.out.println(bojovnik);
        System.out.println("Naživu: "+bojovnik.nazivu());
        System.out.println(bojovnik.grafickyZivot());
    }
}