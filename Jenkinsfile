node {
    checkout scm
    
    stage("Build - Front End") {
        sh 'yarn'
        sh 'ng build ./src/web/HomeChecklist/'
    }
    stage("Build - API") {
        sh 'dotnet publish ./src/api/HomeChecklist/HomeChecklist.csproj --output ./out'
    }
    stage("Deploy - Staging") {

    }
    stage("Deploy - Production") {

    }
}