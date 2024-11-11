pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Build') {
            steps {
                script {
                    // Run the build steps on Ubuntu using 'sh'
                    sh "dotnet restore"
                    sh "dotnet build --configuration Release"
                }
            }
        }

        stage('Test') {
            steps {
                script {
                    // Run the tests on Ubuntu using 'sh'
                    sh "dotnet test --no-restore --configuration Release"
                }
            }
        }

        stage('Publish') {
            steps {
                script {
                    // Run publish step on Ubuntu using 'sh'
                    sh "dotnet publish --no-restore --configuration Release --output ./publish"
                }
            }
        }
    }

    post {
        success {
            echo 'Build, test, and publish successful on Ubuntu!'
        }
    }
}
