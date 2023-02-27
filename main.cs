$pink: #f65c8a;

body {
  width: 100vw;
  height: 100vh;
  display: flex;
  justify-content: center;
  align-items: center;
  font-family: -apple-system, sans-serif;
  
}

.like {
  position: relative;
  cursor: pointer;
  width: 460px;
  height: 46px;
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 12px;
  transition: all 0.3s ease;

  &::after {
    z-index: -2;
    position: absolute;
    content: "";
    display: block;
    width: 100%;
    height: 100%;
    background: #f6f6f8;
    border-radius: 12px;
    transition: all 0.3s cubic-bezier(0.34, 1.56, 0.64, 1);
  }

  

  &:hover {
    &::after {
      border-radius: 10px;
      background: #008000;
      transform: scale(0.88);
      
    }
      }

}





