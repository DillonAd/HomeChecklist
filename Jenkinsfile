node {
    checkout scm
    
    stage("Build - Front End") {
        sh 'docker build ./src/web/HomeChecklist/'
    }
    stage("Build - API") {
        sh 'docker build ./src/api/'
    }
    stage("Deploy - Staging") {

    }
    stage("Deploy - Production") {

    }
}