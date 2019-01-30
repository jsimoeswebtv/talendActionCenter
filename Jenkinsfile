pipeline {
  agent any
  stages {
    stage('get code') {
      steps {
        echo 'hello world'
        withAWS(credentials: 'cdeawscred') {
          s3FindFiles(bucket: 'itx-acm-emea-qa-incoming-sourcefiles', onlyFiles: true, path: 'IQVIA/marketing/LRx')
        }

      }
    }
  }
}