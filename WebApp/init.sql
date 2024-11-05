create schema "Webappdb" authorization admin
CREATE TABLE "Products" ("Id" SERIAL PRIMARY KEY, "Article" INT NOT NULL, "Name" TEXT NOT NULL, "Price" NUMERIC NOT NULL);