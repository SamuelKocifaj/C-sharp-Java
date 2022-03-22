package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {


        lokácia castle = new lokácia("Hrad", "Stojíš před okovanou branou gotického hradu, která je zřejmě jediným vchodem do pevnosti\n" +
                "Klíčová dírka je pokryta pavučinami, což vzbuzuje dojem, že je budova opuštěná \n");
        lokácia forest = new lokácia("Les", "Jsi na lesní cestě, která se klikatí až za obzor, kde mizí v siluetě zapadajícího\n" +
                "slunce. Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.\n");
        lokácia forestPath = new lokácia("Lesní rozcestí", "Nacházíš se na lesním rozcestí.");
        lokácia forest2 = new lokácia("Les", "Jsi na lesní cestě, která se klikatí až za obzor, kde mizí v siluetě zapadajícího\n" +
                "slunce. Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.\n");
        lokácia oak = new lokácia("Rybník", "Došel jsi ke břehu malého rybníka. Hladina je v bezvětří jako zrcadlo. Kousek\n" +
                "od tebe je dřevěná plošina se stavidlem.\n");
        lokácia forrest3 = new lokácia("Les", "Jsi na lesní cestě, která se klikatí až za obzor, kde mizí v siluetě zapadajícího\n" +
                "slunce. Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.\n");
        lokácia house = new lokácia("Dom", "Stojíš před svým rodným domem, cítíš vůni čerstvě nasekaného dřeva, která se line\n" +
                "z hromady vedle vstupních dveří.\n");


        castle.setRight(forest);
        castle.getDescription();

        forest.setLeft(castle);
        forest.setRight(forestPath);

        forestPath.setRight(forest2);
        forestPath.setLeft(forest);
        // Cyklus kde prechádzame pomocou plastných príkazov lokáciami
        boolean isRunning= true;
        Scanner sc= new Scanner(System.in);
        lokácia currentLocation=castle;
    while(isRunning == true) {
        System.out.println("Zadaj prikaz na smer");
        String command = sc.nextLine();
        if (command.equals("koniec")) {
            isRunning = false;
        } else {
            switch (command) {
                case "goto juh":
                    currentLocation = currentLocation.getDown();
                    break;
                case "goto sever":
                    currentLocation = currentLocation.getUp();
                    break;
                case "goto zapad":
                    currentLocation = currentLocation.getLeft();
                    break;
                case "goto vychod":
                    currentLocation = currentLocation.getRight();
                    break;
                default:
                    System.out.println("Zly prikaz");
                    break;
            }
        }

    }

    }
}
