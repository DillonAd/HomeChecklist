node {
    checkout scm
    
    stage("Build - Front End") {
        sh '$(pwd)/build-web.sh'
    }
    stage("Build - API") {
        sh 'dotnet publish $(pwd)/src/api/HomeChecklist/HomeChecklist.csproj --output ./out'
    }
    stage("Deploy - Staging") {

    }
    stage("Deploy - Production") {

    }
}