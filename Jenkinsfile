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
            
            def getDeploymentStatus = sh(script:'eval "kubectl get deployments | grep homechecklist-api"', returnStatus:true)
            
            if (getDeploymentStatus != 0) {
                sh "kubectl create -f ${WORKSPACE}/src/api/api-deployment.yaml"
                sh "kubectl expose deployment homechecklist-api --type=ClusterIP --name=homechecklist-api"
            } else {
                sh "kubectl set image deployment/homechecklist-api homechecklist-api=localhost:1337/homechecklist-api:${tagName}"
            }
        } else {
            echo 'No need to deploy changes from Pull Requests'
        }
    }
}