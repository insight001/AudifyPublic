//0xA334aCa52747dA932F2D1C8Fcf703B0bbfE2c74E  contract address on rinkeby
//deployed using remix 

contract IpfsHash {
 string ipfsHash;
 
 function sendHash(string memory x) public {
   ipfsHash = x;
 }

 function getHash() public view returns (string memory x) {
   return ipfsHash;
 }
}