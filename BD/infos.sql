-- phpMyAdmin SQL Dump
-- version 4.5.4.1
-- http://www.phpmyadmin.net
--
-- Client :  localhost
-- Généré le :  Lun 02 Décembre 2019 à 21:07
-- Version du serveur :  5.7.11
-- Version de PHP :  5.6.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `infos`
--

-- --------------------------------------------------------

--
-- Structure de la table `articles`
--

CREATE TABLE `articles` (
  `num` int(4) NOT NULL,
  `title` varchar(100) NOT NULL,
  `text` varchar(65000) DEFAULT 'sans texte',
  `likes` int(5) DEFAULT '0',
  `dislikes` int(5) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `articles`
--

INSERT INTO `articles` (`num`, `title`, `text`, `likes`, `dislikes`) VALUES
(1, 'Using Multiple Submit Buttons with Default Model Binding and Controller Actions', 'Purpose\nThis guide will demonstrate and explain how you can use ASP.NET MVC to easily create HTML pages with multiple submit buttons, using as little code as possible, and by leveraging the MVC default model binding and controller actions. No JavaScript is required for these techniques.\n\nStructure\nFor developers looking for a quick answer, we will begin with examples of the code required in the Razor view and Controller for two multi-button techniques.\n\nNext, we\'ll take a closer look at the implementation details, security considerations, and ways to pick the best technique.\n\nWe\'ll conclude with some suggested resources for learning more about the topics discussed.', 5, 2),
(2, 'Creating the simplest possible ASP.NET Core form with a POST method', 'Recently I needed to create a simple page for someone to submit an HTML form. The rest of the Azure aplication is running on Azure serverless functions, Logic apps and Cognitive services, but for that last part I wanted something where the user can click on a link, open the page in a web browser (probably on a mobile device), enter a passphrase in a form and the submit through a POST to an SSL encrypted page. I thought of writing a small Xamarin app and submitting through POST to an Azure Function. Another option would be to use a static HTML page and to use Javascript to submit the Form through a POST to that Azure Function. I don\'t exclude these two options for the future.\n\nBut in the meantime I wanted to experiment with a simple Razor page (CSHTML) that would present an HTML Form to the user, and submit this Form to itself with a POST over HTTPS.', 3, 0),
(3, 'Using Prepared Statements', 'Overview of Prepared Statements\nSometimes it is more convenient to use a PreparedStatement object for sending SQL statements to the database. This special type of statement is derived from the more general class, Statement, that you already know.\n\nIf you want to execute a Statement object many times, it usually reduces execution time to use a PreparedStatement object instead.\n\nThe main feature of a PreparedStatement object is that, unlike a Statement object, it is given a SQL statement when it is created. The advantage to this is that in most cases, this SQL statement is sent to the DBMS right away, where it is compiled. As a result, the PreparedStatement object contains not just a SQL statement, but a SQL statement that has been precompiled. This means that when the PreparedStatement is executed, the DBMS can just run the PreparedStatement SQL statement without having to compile it first.\n\nAlthough PreparedStatement objects can be used for SQL statements with no parameters, you probably use them most often for SQL statements that take parameters. The advantage of using SQL statements that take parameters is that you can use the same statement and supply it with different values each time you execute it. Examples of this are in the following sections.\n\nThe following method, CoffeesTable.updateCoffeeSales, stores the number of pounds of coffee sold in the current week in the SALES column for each type of coffee, and updates the total number of pounds of coffee sold in the TOTAL column for each type of coffee:', 1, 0),
(4, 'Welcome To Learn Razor Pages', 'ASP.NET Core Razor Pages is a page-focused framework for building dynamic, data-driven web sites with clean separation of concerns. Based on the latest version of ASP.NET from Microsoft - ASP.NET Core, Razor Pages supports cross platform development and can be deployed to Windows, Unix and Mac operating systems.\n\nThe Razor Pages framework is lightweight and very flexible. It provides the developer with full control over rendered HTML. The framework is built on top of ASP.NET Core MVC, and is enabled by default when MVC is enabled in a .NET Core application. Razor Pages is the recommended framework for cross-platform server-side HTML generation on .NET Core. You do not need to have any knowledge or understanding of MVC to work with Razor Pages.\n\nRazor Pages makes use of the popular C# programming language for server-side programming, and the easy-to-learn Razor templating syntax for embedding C# in HTML markup to generate content for browsers dynamically.', 0, 1),
(5, 'Tableaux, listes et énumérations\n', 'Dans les chapitres précédents, nous avons pu utiliser les types de base du framework .NET, comme int, string, double, etc. Nous allons découvrir ici d\'autres types qui vont s\'avérer très utiles dans la construction de nos applications informatiques. \n\nUne fois bien maîtrisés, vous ne pourrez plus vous en passer ! :p\n\nLes tableaux\nVoici le premier nouveau type que nous allons étudier, le type « tableau ». En déclarant une variable de type tableau, nous allons en fait utiliser une variable qui contient une suite de variables du même type. Prenons cet exemple :', 0, 2),
(6, 'Angular Service Worker - Step-By-Step Guide for turning your Application into a PWA', 'With the Angular Service Worker and the Angular CLI built-in PWA support, it\'s now simpler than ever to make our web application downloadable and installable, just like a native mobile application.\n\nIn this post, we will cover how we can configure the Angular CLI build pipeline to generate applications that in production mode are downloadable and installable, just like native apps.\n\nWe will also add an App Manifest to our PWA, and make the application one-click installable.\n\nI invite you to code along, as we will scaffold an application from scratch using the Angular CLI and we will configure it step-by-step to enable this feature that so far has been exclusive to native apps.\n\nWe will also see in detail what the CLI is doing so that you can also add the Service Worker to an already existing application if needed.\n\nAlong the way, we will learn about the Angular Service Worker design and how it works under the hood, and see how it works in a way that is quite different than other build-time generated service workers.', 1, 0),
(7, 'Des applications ultra-rapides avec Node.js', 'OK, j\'avoue, l\'expression "JavaScript à la papa" est un peu forte. :-°\nMais il y a du vrai là-dedans : JavaScript a eu plusieurs vies. Il a eu mauvaise presse. On l\'a considéré comme un "petit truc parfois bien pratique", longtemps pour "faire des effets dans sa page web". Or, JavaScript est avant tout un langage. Un langage au même titre que le C, Ruby, PHP et bien d\'autres.\n\nAujourd\'hui, JavaScript est de retour et il prend sa revanche. :pirate:\nEn quelque sorte, les développeurs sont en train de découvrir que ce langage qu\'ils ont longtemps ignoré, parfois même méprisé, cache en fait bien son jeu.\n\nNon, JavaScript n\'est pas juste un petit langage utilitaire.\nOui, JavaScript est un langage à part, qui s\'utilise vraiment différemment de Java, du C et d\'un tas d\'autres langages.\nOui, JavaScript peut être compliqué à utiliser, mais recèle derrière ça une vraie puissance.\n\nAlors que ce langage a été créé en 1995 (la préhistoire de l\'informatique, vous vous rendez compte !), il a depuis bien évolué. Pour situer les choses, je dirais même qu\'il a connu 3 vies :', 1, 1);

--
-- Index pour les tables exportées
--

--
-- Index pour la table `articles`
--
ALTER TABLE `articles`
  ADD PRIMARY KEY (`num`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `articles`
--
ALTER TABLE `articles`
  MODIFY `num` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
