pipeline {
    agent {
        label 'windows' // увери се, че Jenkins агентът ти е Windows
    }

    tools {
        dotnet 'dotnet6' // Това трябва да съвпада с името в Jenkins > Global Tool Configuration
    }

    stages {
        stage('Restore dependencies') {
            steps {
                echo 'Restoring NuGet packages...'
                bat 'dotnet restore'
            }
        }

        stage('Build the app') {
            steps {
                echo 'Building the project...'
                bat 'dotnet build --no-restore --configuration Release'
            }
        }

        stage('Run tests') {
            steps {
                echo 'Running unit tests...'
                bat 'dotnet test --no-build --configuration Release --verbosity normal'
            }
        }
    }
}
