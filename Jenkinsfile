pipeline {
  agent any
  stages {
    stage('get code') {
      steps {
        echo 'hello world'
        withAWS(credentials: 'cdeawscred') {
          s3FindFiles(bucket: 'tt', onlyFiles: true, path: '/')
        }

      }
    }
  }
}