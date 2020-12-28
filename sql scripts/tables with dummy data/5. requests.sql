USE LibraryApp;
DROP TABLE IF EXISTS Requests;
CREATE TABLE Requests(
	Id INTEGER IDENTITY(1,1) PRIMARY KEY,
	Title VARCHAR(MAX) NOT NULL,
	Author VARCHAR(MAX) NOT NULL,
);
INSERT INTO Requests(Title,Author) VALUES ('Aghal Paghal','Deshpande, P L');
INSERT INTO Requests(Title,Author) VALUES ('Maqta-e-Ghalib','Garg, Sanjay');
INSERT INTO Requests(Title,Author) VALUES ('Manasa','Kale, V P');
INSERT INTO Requests(Title,Author) VALUES ('India from Midnight to Milennium','Tharoor, Shashi');
INSERT INTO Requests(Title,Author) VALUES ('Great Indian Novel, The','Tharoor, Shashi');
INSERT INTO Requests(Title,Author) VALUES ('O Jerusalem!','Lapierre, Dominique');
INSERT INTO Requests(Title,Author) VALUES ('City of Joy, The','Lapierre, Dominique');
INSERT INTO Requests(Title,Author) VALUES ('Freedom at Midnight','Lapierre, Dominique');
INSERT INTO Requests(Title,Author) VALUES ('Winter of Our Discontent, The','Steinbeck, John');
INSERT INTO Requests(Title,Author) VALUES ('On Education','Russell, Bertrand');
INSERT INTO Requests(Title,Author) VALUES ('Free Will','Harris, Sam');
INSERT INTO Requests(Title,Author) VALUES ('Bookless in Baghdad','Tharoor, Shashi');
INSERT INTO Requests(Title,Author) VALUES ('Case of the Lame Canary, The','Gardner, Earle Stanley');
INSERT INTO Requests(Title,Author) VALUES ('Theory of Everything, The','Hawking, Stephen');
INSERT INTO Requests(Title,Author) VALUES ('New Markets & Other Essays','Drucker, Peter');
INSERT INTO Requests(Title,Author) VALUES ('Electric Universe','Bodanis, David');
INSERT INTO Requests(Title,Author) VALUES ('Hunchback of Notre Dame, The','Hugo, Victor');
INSERT INTO Requests(Title,Author) VALUES ('Burning Bright','Steinbeck, John');
INSERT INTO Requests(Title,Author) VALUES ('Age of Discontuinity, The','Drucker, Peter');
INSERT INTO Requests(Title,Author) VALUES ('Doctor in the Nude','Gordon, Richard');
INSERT INTO Requests(Title,Author) VALUES ('Down and Out in Paris & London','Orwell, George');
INSERT INTO Requests(Title,Author) VALUES ('Identity & Violence','Sen, Amartya');
INSERT INTO Requests(Title,Author) VALUES ('Beyond the Three Seas','Dalrymple, William');
INSERT INTO Requests(Title,Author) VALUES ('Talking Straight','Iacoca, Lee');
INSERT INTO Requests(Title,Author) VALUES ('Maugham''s Collected Short Stories, Vol 3','Maugham, William S');
