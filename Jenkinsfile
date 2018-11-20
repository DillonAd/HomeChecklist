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
    stage("Deploy") {   
        //Only deploy on accepted changes
        if("${BRANCH_NAME}" == 'master' || "${BRANCH_NAME}" == 'k8s') {
            sh "docker push localhost:1337/homechecklist-web:${tagName}"
            sh "docker push localhost:1337/homechecklist-api:${tagName}"

            sh "kubectl create -f ${WORKSPACE}/src/api/api-deployment.yml"
        } else {
            pritnln 'No need to deploy changes from Pull Requests'
        }
    }
}