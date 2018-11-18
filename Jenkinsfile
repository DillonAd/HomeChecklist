node {
    checkout scm

    def tagName = ''

    if("${BRANCH_NAME}" == 'master') {
        tagName = "${BUILD_NUMBER}"
    } else {
        tagName = "${BRANCH_NAME}-${BUILD_NUMBER}"
    }

    stage("Build - Front End") {
        sh "docker build --tag localhost:1337/homechecklist-web:${tagName} ./src/web/HomeChecklist/"
    }
    stage("Build - API") {
        sh "docker build --tag localhost:1337/homechecklist-api:${tagName} ./src/api/"
    }

    //Only deploy on accepted changes
    if("${BRANCH_NAME}" == 'master') {
        stage("Deploy - Production") {
            sh "docker push localhost:1337/homechecklist-web:${tagName}"
            sh "docker push localhost:1337/homechecklist-api:${tagName}"

            sh "kubectl create -f $pwd/src/api/api-deployment.yaml"
        }
    }
}