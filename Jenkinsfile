pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh '''dotnet restore ./CetaitQuoiLeContexte/CetaitQuoiLeContexte.sln
'''
        sh 'dotnet build ./CetaitQuoiLeContexte/CetaitQuoiLeContexte.sln'
      }
    }
  }
}