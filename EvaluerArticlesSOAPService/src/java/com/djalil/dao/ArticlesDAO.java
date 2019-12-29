/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.djalil.dao;

import com.djalil.entites.Article;
import com.djalil.jdbc.DataBase;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author 1995156
 */
public class ArticlesDAO {

    public  static ArrayList<Article> getListArticles() {
        ArrayList<Article> articles = new ArrayList<Article>();
        Connection connexion = DataBase.getInstance();
        ResultSet rs;
        try {

            String sql = "select num, title, text, likes, dislikes from articles ";
            PreparedStatement stm = connexion.prepareStatement(sql);
            rs = stm.executeQuery(sql);

            int num, likes, dislikes;
            String title, text;
            while (rs.next()) {
                num = rs.getInt("num");
                title = rs.getString("title");
                text = rs.getString("text");
                likes = rs.getInt("likes");
                dislikes = rs.getInt("dislikes");
                Article art = new Article(num, title, text, likes, dislikes);
                articles.add(art);
            }
            return articles;
        } catch (SQLException ex) {
            Logger.getLogger(ArticlesDAO.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
    }
    public  static Article getArticle(int numArt) {
        Connection connexion = DataBase.getInstance();
         Article art = null;
        ResultSet rs;
        try {

            String sql = "select num, title, text, likes, dislikes from articles "
                   + " where num=?  ";
            PreparedStatement stm = connexion.prepareStatement(sql);
            stm.setInt(1, numArt);
            rs = stm.executeQuery();
            int num, likes, dislikes;
            String title, text;
            while (rs.next()) {
                num = rs.getInt("num");
                title = rs.getString("title");
                text = rs.getString("text");
                likes = rs.getInt("likes");
                dislikes = rs.getInt("dislikes");
                art = new Article(num, title, text, likes, dislikes);
            }
            return art;
        } catch (SQLException ex) {
            Logger.getLogger(ArticlesDAO.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
    }


       public  static ArrayList<Article> getArticlesByKeyWord(String keywords) {
        ArrayList<Article> articles = new ArrayList<Article>();
         ArrayList<Article> sourceList = ArticlesDAO.getListArticles();
        Connection connexion = DataBase.getInstance();
        sourceList.forEach((article) -> {
            if (article.getTitle().toLowerCase().contains(keywords.toLowerCase())
                    || article.getText().toLowerCase().contains(keywords.toLowerCase())) {
                articles.add(article);
            }
        });
        return articles;
    }
       
    public static boolean doLikeArticle(int num) {
        Connection connexion = DataBase.getInstance();
        ResultSet rs;
        try {
            String sql = "update articles set likes=likes+1 where num=?  ";
            PreparedStatement stm = connexion.prepareStatement(sql);
            stm.setInt(1, num);
            int n = stm.executeUpdate();
            if (n>0) return true;
        } catch (SQLException ex) {
            Logger.getLogger(ArticlesDAO.class.getName()).log(Level.SEVERE, null, ex);
            return false;
        }
        return false;
    }
    
    public static boolean doDislikeArticle(int num) {
        Connection connexion = DataBase.getInstance();
        ResultSet rs;
        try {
            String sql = "update articles set dislikes=dislikes+1 where num=?  ";
            PreparedStatement stm = connexion.prepareStatement(sql);
            stm.setInt(1, num);
            int n = stm.executeUpdate();
            if (n>0) return true;
        } catch (SQLException ex) {
            Logger.getLogger(ArticlesDAO.class.getName()).log(Level.SEVERE, null, ex);
            return false;
        }
        return false;
    }
}
