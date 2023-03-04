pipeline
{
    agent any
    
    stages
    {
        stage('Checkout')
        {
            steps
            {
                //git branch: """${BRANCH_NAME}""", credentialsId: 'GitPat', url: 'https://github.com/rpsingh77/Weather.git'
				script
				{
					echo ${BRANCH_NAME}
				}
            }
            
        }
    }
}