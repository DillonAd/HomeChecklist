node {
    checkout scm
    
    stage("Build - Front End") {
        sh 'docker build --tag localhost:1337/homechecklist-web-0 ./src/web/HomeChecklist/'
        sh 'docker push localhost:1337/homechecklist-web-0'
    }
    stage("Build - API") {
        sh 'docker build --tag localhost:1337/homechecklist-api-0 ./src/api/'
        sh 'docker push localhost:1337/homechecklist-api-0'
    }
    stage("Deploy - Staging") {

    }
    stage("Deploy - Production") {

    }
}