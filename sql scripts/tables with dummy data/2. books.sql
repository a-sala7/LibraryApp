USE LibraryApp;
DROP TABLE IF EXISTS Books;
CREATE TABLE Books (
	Id INTEGER IDENTITY(1,1) PRIMARY KEY,
	Title VARCHAR(MAX) NOT NULL,
	Author VARCHAR(MAX) NOT NULL,
	Price MONEY NOT NULL
);
INSERT INTO Books(Title,Author,Price) VALUES ('Fundamentals of Wavelets','Goswami, Jaideva',46.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Data Smart','Foreman, John',46.99);
INSERT INTO Books(Title,Author,Price) VALUES ('God Created the Integers','Hawking, Stephen',5.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Superfreakonomics','Dubner, Stephen',17.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Orientalism','Said, Edward',17.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Nature of Statistical Learning Theory, The','Vapnik, Vladimir',16.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Integration of the Indian States','Menon, V P',31.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Drunkard''s Walk, The','Mlodinow, Leonard',21.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Image Processing & Mathematical Morphology','Shih, Frank',6.99);
INSERT INTO Books(Title,Author,Price) VALUES ('How to Think Like Sherlock Holmes','Konnikova, Maria',4.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Data Scientists at Work','Sebastian Gutierrez',26.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Slaughterhouse Five','Vonnegut, Kurt',23.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Birth of a Theorem','Villani, Cedric',26.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Structure & Interpretation of Computer Programs','Sussman, Gerald',49.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Age of Wrath, The','Eraly, Abraham',27.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Trial, The','Kafka, Frank',52.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Statistical Decision Theory','Pratt, John',38.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Data Mining Handbook','Nisbet, Robert',37.99);
INSERT INTO Books(Title,Author,Price) VALUES ('New Machiavelli, The','Wells, H. G.',19.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Physics & Philosophy','Heisenberg, Werner',32.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Making Software','Oram, Andy',39.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Analysis, Vol I','Tao, Terence',30.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Machine Learning for Hackers','Conway, Drew',18.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Signal and the Noise, The','Silver, Nate',23.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Python for Data Analysis','McKinney, Wes',34.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Introduction to Algorithms','Cormen, Thomas',15.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Beautiful and the Damned, The','Deb, Siddhartha',12.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Outsider, The','Camus, Albert',21.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Complete Sherlock Holmes, The - Vol I','Doyle, Arthur Conan',57.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Complete Sherlock Holmes, The - Vol II','Doyle, Arthur Conan',32.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Wealth of Nations, The','Smith, Adam',28.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Pillars of the Earth, The','Follett, Ken',21.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Mein Kampf','Hitler, Adolf',18.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Tao of Physics, The','Capra, Fritjof',31.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Surely You''re Joking Mr Feynman','Feynman, Richard',10.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Farewell to Arms, A','Hemingway, Ernest',43.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Veteran, The','Forsyth, Frederick',27.99);
INSERT INTO Books(Title,Author,Price) VALUES ('False Impressions','Archer, Jeffery',9.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Last Lecture, The','Pausch, Randy',22.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Return of the Primitive','Rand, Ayn',47.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Jurassic Park','Crichton, Michael',39.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Russian Journal, A','Steinbeck, John',21.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Tales of Mystery and Imagination','Poe, Edgar Allen',25.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Freakonomics','Dubner, Stephen',9.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Hidden Connections, The','Capra, Fritjof',5.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Story of Philosophy, The','Durant, Will',10.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Asami Asami','Deshpande, P L',47.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Journal of a Novel','Steinbeck, John',17.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Once There Was a War','Steinbeck, John',22.99);
INSERT INTO Books(Title,Author,Price) VALUES ('Moon is Down, The','Steinbeck, John',10.99);
