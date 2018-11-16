node {
    checkout scm
    
    stage("Build - Front End") {
        sh 'docker build ./src/web/HomeChecklist/'
    }
    stage("Build - API") {
        sh 'dotnet publish $(pwd)/src/api/HomeChecklist/HomeChecklist.csproj --output ./out'
    }
    stage("Deploy - Staging") {

    }
    stage("Deploy - Production") {

    }
}