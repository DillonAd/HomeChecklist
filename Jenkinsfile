node {
    checkout scm
    
    stage("Build - Front End") {
        sh 'docker build --tag localhost:1337/homechecklist-web-${BUILD_NUMBER} ./src/web/HomeChecklist/'
    }
    stage("Build - API") {
        sh 'docker build --tag localhost:1337/homechecklist-api-${BUILD_NUMBER} ./src/api/'
    }
    stage("Deploy - Production") {
        sh 'docker push localhost:1337/homechecklist-web:${BUILD_NUMBER}'
        sh 'docker push localhost:1337/homechecklist-api:${BUILD_NUMBER}'
    }
}