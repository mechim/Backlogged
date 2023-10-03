all: compile run
	
compile: 
	mcs main.cs game.cs gameLibrary.cs review.cs reviewLibrary.cs reviewManager.cs menu.cs saveLoad.cs gameManager.cs

run: 
	mono main.exe

clean:
	-rm $(wildcard *.exe)
