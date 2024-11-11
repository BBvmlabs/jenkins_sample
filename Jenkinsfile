pipeline {
    agent any

    environment {
        DOTNET_CLI_HOME = "C:\\Program Files\\dotnet"  // Windows-specific location for .NET CLI home
    }

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Build') {
            steps {
                script {
                    if (isUnix()) {
                        // Unix (Linux/macOS) specific
                        sh "dotnet restore"
                        sh "dotnet build --configuration Release"
                    } else {
                        // Windows specific
                        bat "cd ${DOTNET_CLI_HOME} && dotnet restore"
                        bat "dotnet build --configuration Release"
                    }
                }
            }
        }

        stage('Test') {
            steps {
                script {
                    if (isUnix()) {
                        // Unix (Linux/macOS) specific
                        sh "dotnet test --no-restore --configuration Release"
                    } else {
                        // Windows specific
                        bat "dotnet test --no-restore --configuration Release"
                    }
                }
            }
        }

        stage('Publish') {
            steps {
                script {
                    if (isUnix()) {
                        // Unix (Linux/macOS) specific
                        sh "dotnet publish --no-restore --configuration Release --output ./publish"
                    } else {
                        // Windows specific
                        bat "dotnet publish --no-restore --configuration Release --output .\\publish"
                    }
                }
            }
        }
    }

    post {
        success {
            echo 'Build, test, and publish successful!'
        }
    }
}
