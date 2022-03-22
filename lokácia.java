package com.company;
public class lokácia {
    private String name;
    private lokácia up;
    private lokácia down;
    private lokácia left;
    private lokácia right;
    public lokácia(String name, String description){
        this.name=name;
    }
    public lokácia getUp(){
        return up;
    }
    public void setUp(lokácia up){
        this.up=up;
    }
    public lokácia getDown(){
        return down;
    }
    public void setDown(lokácia down){
        this.down=down;
    }
    public lokácia getLeft(){
        return left;
    }
    public void setLeft(Location left){
        this.left=left;
    }
    public lokácia getRight(){
        return right;
    }

}
