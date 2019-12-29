<%-- 
    Document   : index
    Created on : 2019-11-28, 20:51:04
    Author     : user
--%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt" %>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Ajouter Article</title>
        <link href="css/style.css" rel="stylesheet" type="text/css"/>
    </head>
    <body>
        <div class="header">
            <p>Ajouter un article</p>
        </div>
        <c:if test="${! requestScope.isAdded}">
            <div class="divMessage">
                <p> <H1> ${requestScope.message}</h1></p>
            </div>
        </c:if>

        <div> 
            <form action="Controleur?action=ajouter" method="post">
                <div>
                    <label for="name">Titre :</label>
                    <input type="text" id="titre" name="titre" >
                </div>
                <div>
                    <label for="msg">Texte :</label>
                    <textarea id="texte" name="texte"></textarea>
                </div>
                <div class="button">
                    <button type="submit">Enregistrer l article</button>
                </div>
            </form>
        </div>
         <div class="header">
            <p>Application Développer par: </p>
             <p>Abdeldjalil Guendouz</p>
        </div>
    </body>
</html>
