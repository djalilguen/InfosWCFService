/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.djalil.ws;

import com.djalil.dao.ArticlesDAO;
import com.djalil.entites.Article;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author 1995156
 */
@WebService(serviceName = "ArticlesWS")
public class ArticlesWS {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "getListArticles")
    public ArrayList<Article> getListArticles() {
        return ArticlesDAO.getListArticles();
    }
    
     @WebMethod(operationName = "getArticle")
    public Article getArticle(@WebParam(name = "num") int numArt) {
        return ArticlesDAO.getArticle(numArt);
    }

    @WebMethod(operationName = "searchArticles")
    public ArrayList<Article> searchArticles(@WebParam(name = "keywords") String keywords) {
        return ArticlesDAO.getArticlesByKeyWord(keywords);
    }    

     @WebMethod(operationName = "like")
    public boolean doLikeArticle(@WebParam(name = "numArticle") int num) {
        return ArticlesDAO.doLikeArticle(num);
    }
    
     @WebMethod(operationName = "dislike")
    public boolean dodisLikeArticle(@WebParam(name = "numArticle") int num) {
        return ArticlesDAO.doDislikeArticle(num);
    }
}
