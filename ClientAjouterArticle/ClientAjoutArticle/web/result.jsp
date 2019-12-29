<%-- 
    Document   : result
    Created on : 2019-11-28, 22:40:42
    Author     : user
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt" %>

<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>resultat</title>
    </head>
    <body>
         <c:if test="${requestScope.isAdded}">
            <div>
                <H1> ${requestScope.message}</h1>
            </div>
        </c:if>

        <div> 
            <form action="Controleur?action=retour" method="post">
                <div>
                    <label for="name">Titre :</label>
                    <input type="text" id="titre" name="titre" value="${requestScope.titre}" readonly>
                </div>
                <div class="button">
                    <button type="submit">Retour</button>
                </div>
            </form>
        </div>
    </body>
</html>
