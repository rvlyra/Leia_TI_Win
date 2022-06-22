cd C:\rlyra\Documents\Dev\Leia_TI\Win\

# rem "O diretório não existe. Clonando projeto."
	
dotnet --version

dotnet new mvc -o livraria -au none

cd livraria\

echo "Incluindo pacotes EF Core"
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore 
dotnet add package Microsoft.EntityFrameworkCore.Relational 
dotnet add package Microsoft.EntityFrameworkCore.Tools 
		
	
touch logTarefa.txt 
echo "Tarefa realizada em %date%, %time%" >> logTarefa.txt


start logTarefa.txt 

code .

ls -la

close .
