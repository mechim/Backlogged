all: compile run
	
compile: 
	mcs main.cs 

run: 
	mono main.exe
