/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.djalil.jdbc;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author 1995156
 */
public class DataBase {
    private static String DRIVER = "com.mysql.cj.jdbc.Driver",
                    URL = "jdbc:mysql://localhost/infos?serverTimezone=UTC",
                    USER = "root",
                    PASSWORD = "root";

    private static Connection cnx = null;
    
    private DataBase() {}
    
    public static Connection getInstance() {
        try {
            if (cnx == null || cnx.isClosed()) {
                Class.forName(DRIVER);
                cnx = DriverManager.getConnection(URL, USER, PASSWORD);
            }
        } catch (SQLException ex) {
            Logger.getLogger(DataBase.class.getName()).log(Level.SEVERE, null, ex);
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(DataBase.class.getName()).log(Level.SEVERE, null, ex);
        }
        return cnx;
    }
}
