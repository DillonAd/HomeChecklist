node {
    checkout scm
    
    stage("Build - Front End") {
        sh 'pushd $(pwd)/src/web/HomeChecklist/ && yarn'
        sh 'ng build && popd'
    }
    stage("Build - API") {
        sh 'dotnet publish $(pwd)/src/api/HomeChecklist/HomeChecklist.csproj --output ./out'
    }
    stage("Deploy - Staging") {

    }
    stage("Deploy - Production") {

    }
}