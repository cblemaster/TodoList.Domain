# TodoList.Domain
## About
+Domain modeling for a basic todo app
+Uses my best understanding of domain driven design concepts
+As my knowledge improves so will the quality of this model
## Built with
+NET 9 / C# 13
+Microsoft Visual Studio Community 2022
+Help from the internet, especially wizards like Steve Smith
## Use cases
+TBD, currently documented elsewhere
## Domain rules
+TBD, currently documented elsewhere
## Improvement opportunities
+Continue looking into specifications and guard clauses, I'm not jazzed about the way validation is implemented, e.g., weird asp.net controller-type data annotation, throws exceptions
+For now add errors to the data annotations and make them reusable
+The goal is to prevent invalid entities from being instantiated
+Look into domain events and how to implement, I might not need them depending on how I implement the aggregates?
