/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.djalil.entites;

import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author 1995156
 */
@XmlRootElement
public class Article {

    private int num;
    private String title;
    private String text;
    private int likes;
    private int dislikes;

    public Article() {
    }

    public Article(int num, String title, String text, int likes, int dislikes) {
        this.num = num;
        this.title = title;
        this.text = text;
        this.likes = likes;
        this.dislikes = dislikes;
    }

    public Article(String title, String text) {
        this.title = title;
        this.text = text;
    }

    public int getNum() {
        return num;
    }

    public void setNum(int num) {
        this.num = num;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getText() {
        return text;
    }

    public void setText(String text) {
        this.text = text;
    }

    public int getLikes() {
        return likes;
    }

    public void setLikes(int likes) {
        this.likes = likes;
    }

    public int getDislikes() {
        return dislikes;
    }

    public void setDislikes(int dislikes) {
        this.dislikes = dislikes;
    }
    
    

}
