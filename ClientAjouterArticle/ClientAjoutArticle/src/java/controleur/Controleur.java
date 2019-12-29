/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controleur;

import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import utils.tools;

/**
 *
 * @author user
 */
public class Controleur extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
       String titre = request.getParameter("titre");
       String texte = request.getParameter("texte");
       String action = request.getParameter("action");
       String jspPage ="index.jsp";
       String message ="";
       boolean isAdded =false;
       
     if ((action == null) || (action.length() < 1)) {
            action = "retour";
        } 
     if ("ajouter".equalsIgnoreCase(action)) {
       if("".equals(titre) || "".equals(texte) && titre ==null && texte ==null){
            message="le titre et le texte ne doivent pas etre vide";
            jspPage ="index.jsp";
       }else{
            isAdded = tools.addArticle(titre, texte);
          if (isAdded){
              message="Votre article a ete bien ajoute !";
              jspPage ="result.jsp";
          }else{
              message="Votre article n est pas pu bien ajoute ";
              jspPage ="index.jsp";
          }
       }
       request.setAttribute("message", message);
       request.setAttribute("titre", titre);
       request.setAttribute("texte", texte);
       request.setAttribute("isAdded", isAdded);
     }else{
     jspPage ="index.jsp";
     }
        dispatch(jspPage, request, response);
       
    }
        private void dispatch(String jspPage, HttpServletRequest request,
            HttpServletResponse response) throws ServletException, IOException {
        if (jspPage != null) {
            RequestDispatcher rd = request.getRequestDispatcher(jspPage);
            rd.forward(request, response);
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
