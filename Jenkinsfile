pipeline
{
    agent any
    
    stages
    {
        stage('Checkout')
        {
            steps
            {
                git branch: 'main', credentialsId: 'GitPat', url: 'https://github.com/rpsingh77/Weather.git'
            }
            
        }
        
        stage('Build')
        {
            steps
            {
                dotnetBuild configuration: 'Debug', project: 'Weather.sln'
            }
        }
        
        stage('Test')
        {
            steps
            {
               dotnetTest project: 'Weather.sln'
            }
        }
        
        stage('Publish')
        {
            steps
            {
                dotnetPublish project: 'Weather.sln'
                sh "echo ${BUILD_NUMBER}"
                zip zipFile: """Weather_${BUILD_NUMBER}.zip""", archive: false, dir: './WeatherApi/bin/Debug/net6.0/publish'
            }
        }
        
        stage('Deploy')
        {
            steps
            {
                script
                {
					echo 'Push zip to repo'
					
                    //withCredentials([usernamePassword(credentialsId: 'GitPat', passwordVariable: 'GIT_PASSWORD', usernameVariable: 'GIT_USERNAME')])
                    //{
                        //sh """
                        //git add Weather_${BUILD_NUMBER}.zip
                        //git config --global user.email "rpsingh77@gmail.com"
                        //git config --global user.name "Ram Singh"
                        //git commit -m 'From Jenkins Build' Weather_${BUILD_NUMBER}.zip
                        //git push https://${GIT_USERNAME}:${GIT_PASSWORD}@github.com/rpsingh77/Weather.git
						
                    //"""    
                    //}    
                }
            }
        }
    }
}