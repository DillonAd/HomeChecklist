node {
    checkout scm
    
    stage("Build - Front End") {
        cd ./src/web/HomeChecklist/
        yarn
        ng build
    }
    stage("Build - API") {
        cd ./src/api/
        dotnet publish ./HomeChecklist/HomeChecklist.csproj --output ./out
    }
    stage("Deploy - Staging") {

    }
    stage("Deploy - Production") {

    }
}