package com.company;
import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;
public class Main {

    public static void main(String[] args) {
        int[] pole = new int[20];
        double sucet=0;
        Random randNum = new Random();
        for (int i = 0; i < 20; i++) {

            int randomcislo=(int)(Math.random()*50);
            pole[i]=randomcislo+1;
        }
       for(int cisla :pole  ){
           System.out.println(" "+ cisla);
       }
        for (int i = 0; i <pole.length; i++) {
            sucet=sucet+pole[i];
        }
        double priemer= sucet / pole.length;
       System.out.println("sucet:"+sucet);
       System.out.println("Priemer je:"+priemer);
       Arrays.sort(pole);
       System.out.println("najmenšia hodnota je: "+pole[1]);
       System.out.println("najväčšia hodnota je: "+pole[19]);
    }
}
