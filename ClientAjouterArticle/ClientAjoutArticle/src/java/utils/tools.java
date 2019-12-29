/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package utils;

import dao.Article;
import dao.ObjectFactory;
import dao.Service1;

/**
 *
 * @author user
 */
public class tools {
    public static boolean addArticle(String titre, String texte){
        Service1 ws=null;
        Article art=null;
        try{
        ObjectFactory fact = new ObjectFactory();
        fact.createAddArticle();
        art = new Article();
        
        art.setText( fact.createArticleText(texte));
        art.setTitle(fact.createArticleTitle(titre));
        art.setLikes(0);
        art.setDislikes(0);
         ws = new Service1();
         return ws.getBasicHttpBindingIService1().addArticle(art);
        }catch(Exception e) {
        return false;
        }
       
    }
    
}
